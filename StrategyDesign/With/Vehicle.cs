namespace With
{
    public class Vehicle{
        IDriveStrategy driveStrategy;
        public Vehicle(IDriveStrategy driveStrategy){
            this.driveStrategy  = driveStrategy;
        }

        public void Drive(){
            driveStrategy.Drive();
        }
    }
    
}

