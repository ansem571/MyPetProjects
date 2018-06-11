using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary.SpecialFormulas
{
    public class FramerateUpdateService
    {
        private int _fps;
        private int _frames;
        private long _currentTick;
        private long _lastTime = Environment.TickCount;
        private float _deltaTime;
        private readonly int _updateInterval = 1000;
        private readonly float _smoothing = 0.9f;
        private bool _isRunning = false;

        public void Init()
        {
            _isRunning = true;
            Task.Run(() => Update());
        }

        public void ShutDown()
        {
            _isRunning = false;
        }

        private void Update()
        {
            while (_isRunning)
            {
                _currentTick = Environment.TickCount;
                if (_currentTick - _lastTime >= _updateInterval)
                {
                    _fps = _frames;
                    _frames = 0;
                    _lastTime = _currentTick;
                }
                _frames++;

                _deltaTime = _currentTick - _lastTime;
            }
        }

        public int GetFrames()
        {
            return _frames;
        }

        public long GetFPS()
        {
            return _currentTick - _lastTime == 0 ? 1 : _fps /(_currentTick - _lastTime);
        }

        public float GetDeltaTime()
        {
            return (_deltaTime / _updateInterval);
        }
    }
}
