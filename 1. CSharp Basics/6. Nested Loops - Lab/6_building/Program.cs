int floors = int.Parse(Console.ReadLine());
int roomsPerFloor = int.Parse(Console.ReadLine());

for (int floor = floors; floor >= 1; floor--)
{   
    string floorRooms = "";

    for (int room = 0; room < roomsPerFloor; room++)
    {
        string typeRoom = "";

        if (floor == floors)
        {
            typeRoom = "L";
        }
        else
        {
            if (floor % 2 == 0)
            {
                typeRoom = "O";
            }
            else
            {
                typeRoom = "A";
            }
        }
        
        floorRooms += $"{typeRoom}{floor}{room} ";
    }

    Console.WriteLine(floorRooms);
}