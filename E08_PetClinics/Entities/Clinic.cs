using System;
using System.Text;

namespace E08_PetClinics.Entities
{
    public class Clinic
    {
        private int roomNumber;
        private RoomsRegister roomsregister;
        private int occupiedRooms;

        public Clinic(string name, int roomsNumber)
        {
            this.Name = name;
            this.RoomNumber = roomsNumber;
            this.roomsregister = new RoomsRegister(this.RoomNumber);
            this.occupiedRooms = 0;
        }

        public string Name { get; private set; }

        public int RoomNumber
        {
            get { return this.roomNumber; }
            set
            {
                if (value % 2 == 0)
                {
                    throw new ArgumentException("Invalid Operation!");
                }

                this.roomNumber = value;
            }
        }

        public bool TryAddPet(Pet currentPet)
        {
            foreach (var roomIndex in this.roomsregister)
            {
                if (this.roomsregister[roomIndex] == null)
                {
                    this.roomsregister[roomIndex] = currentPet;
                    this.occupiedRooms++;
                    return true;
                }
            }
            return false;
        }

        public bool TryRelesePet()
        {
            var censtralRoom = this.RoomNumber / 2;

            for (int i = 0; i < this.RoomNumber; i++)
            {
                int currentIndex = (censtralRoom + i) % this.RoomNumber;
                if (this.roomsregister[currentIndex] != null)
                {
                    this.roomsregister[currentIndex] = null;
                    this.occupiedRooms--;
                    return true;
                }
            }

            return false;
        }

        public string Print()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < this.RoomNumber; i++)
            {
                sb.AppendLine(this.Print(i));
            }

            return sb.ToString().Trim();
        }

        public string Print(int roomIndex)
        {
            return this.roomsregister[roomIndex]?.ToString() ?? "Room empty";
        }

        public bool HasEmptyRooms()
        {
            return this.occupiedRooms < this.RoomNumber;
        }
    }
}