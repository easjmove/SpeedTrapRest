using SpeedTrapRest.Model;

namespace SpeedTrapRest.Repositories
{
    public class SpeedTrapsRepository
    {
        private List<SpeedTrap> _data = new List<SpeedTrap>();

        public List<SpeedTrap> GetAll()
        {
            return new List<SpeedTrap>(_data);
        }

        public void Add(SpeedTrap speedTrap)
        {
            _data.Add(speedTrap);
        }
    }
}
