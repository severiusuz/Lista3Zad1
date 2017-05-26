using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Zad1.Core;

namespace Zad1
{
    public partial class Form1 : Form
    {
        private TrafficLights _tLights;
        private readonly Color _offColor;
        private readonly List<Action> _commands;
        private int _currentIndex;

        public Form1()
        {
            InitializeComponent();
            _tLights = new TrafficLights();
            _offColor = Color.Gray;
            _currentIndex = 0;
            _commands = new List<Action>
            {
                _tLights.SetStop,
                _tLights.SetPrepareToStart,
                _tLights.SetStart,
                _tLights.SetPrepareToStop
            };
            timer1.Start();
        }

        private void DisplayColors(TrafficLights lights)
        {
            SetColors(lights);
        }

        private void SetColors(TrafficLights lights)
        {
            panel_red.BackColor = lights.Red ? Color.Red : _offColor;
            panel_yellow.BackColor = lights.Yellow ? Color.Yellow : _offColor;
            panel_green.BackColor = lights.Green ? Color.Green : _offColor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_currentIndex >= _commands.Count)
                _currentIndex = 0;

            _commands.ElementAt(_currentIndex++).Invoke();
            DisplayColors(_tLights);
        }
    }
}
