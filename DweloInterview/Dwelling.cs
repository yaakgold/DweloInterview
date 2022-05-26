using System;
using System.Collections.Generic;
using System.Text;

namespace DweloInterview
{
    public class Dwelling
    {
        static List<Dwelling> dwellings = new List<Dwelling>();

        public bool Occupied { get; private set; }
        public Hub MyHub { get; private set; }

        private string _dwellingName;

        public Dwelling(string _name)
        {
            _dwellingName = _name;

            dwellings.Add(this);
        }

        public override string ToString()
        {
            return _dwellingName;
        }

        public void SetOccupiedStatus(bool val)
        {
            Occupied = val;
        }

        public void InstallHub(Hub newHub)
        {
            MyHub = newHub;
        }

        public static List<Dwelling> ListDwellings() => dwellings;
    }
}
