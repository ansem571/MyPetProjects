using EscapeTheDungeon.Contracts;
using System;

namespace EscapeTheDungeon.Services.Implementations
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
            else
            {
                //game is currently running
            }
        }
        
        public void Quit()
        {
            _running = false;
            //close out of game
        }

        public void Play()
        {
            while (_running)
            {
                //Display Current Floor Map
                var currentFloor = _player.CurrentLocation.Z;
                _mapService.DisplayFloorMap((int)currentFloor);
                //Display nearby tiles relative to current location
                //Display valid directional
                //Process movement
            }
        }
    }
}
