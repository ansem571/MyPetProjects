using EscapeTheDungeon.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeTheDungeon.Services
{
    public class GameManager
    {
        private readonly Player _player;
        private readonly MapService _mapService;
        private bool _running = false;

        public GameManager(Player player, MapService mapService)
        {
            _player = player ?? throw new ArgumentNullException(nameof(player));
            _mapService = mapService ?? throw new ArgumentNullException(nameof(mapService));
        }

        public void Startup()
        {
            if (!_running)
            {
                _running = true;
            }
        }
        
        public void Quit()
        {
            _running = false;
        }

        public void Play()
        {
            while (_running)
            {
                //Display Current Floor Map
                //Display nearby tiles relative to current location
                //Display valid directional
                //Process movement
            }
        }
    }
}
