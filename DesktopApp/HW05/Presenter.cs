using HW05.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW05
{
    public class Presenter
    {
        private readonly Model _model;
        private readonly View _view;

        public Presenter(Model model, View view)
        {
            _model = model;
            _view = view;

            _view.StartGame += new EventHandler<EventArgs>(StartNewGame);
            _view.ClickCell += new EventHandler<EventArgs>(OnCellClicked);
        }

        public void StartNewGame(object sender, EventArgs e)
        {
            _model.ClearBoard();
            _view.ClearBoard();
            _view.IsGameStart = true;
            _view.ShowInfo("New game started!");
            
            if (_view.IsBotMoveFirst)
            {
                BotMove();
            }
        }

        private void BotMove()
        {
            Random rnd = new Random();
            bool isPlaced;
            int x = rnd.Next(0, 3);
            int y = rnd.Next(0, 3);

            do
            {
                try
                {
                    _model.SetMove(x, y);
                    _view.UpdateButton(x * 3 + y, _model.CurrentPlayer);
                    isPlaced = true;
                }
                catch (Exception ex)
                {
                    isPlaced = false;
                    x = rnd.Next(0, 3);
                    y = rnd.Next(0, 3);
                }
            } while (!isPlaced);

            _view.ShowInfo("Computer made a move");
            if (CheckWinDraw()) return;
            _model.SwitchPlayers();
        }

        public void OnCellClicked(object sender, EventArgs e)
        {
            if (!_view.IsGameStart)
            {
                _view.ShowError("Game doesn't start");
                return;
            }

            Button button = sender as Button;
            int num = int.Parse(Regex.Match(button.Name, @"\d+").Value) - 1;

            int x = num / 3;
            int y = num % 3;

            try
            {
                _model.SetMove(x, y);
                _view.UpdateButton(num, _model.CurrentPlayer);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
                return;
            }

            if (CheckWinDraw()) return;
            _model.SwitchPlayers();

            BotMove();
        }

        private bool CheckWinDraw()
        {
            if (_model.CheckBoardWinner())
            {
                _view.ShowInfo($"Player {_model.CurrentPlayer} wins!");
                _view.IsGameStart = false;
                return true;
            }

            if (_model.IsBoardFull())
            {
                _view.ShowInfo("Draw!");
                _view.IsGameStart = false;
                return true;
            }

            return false;
        }
    }
}
