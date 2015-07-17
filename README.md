# RoboSim ![alt text](https://github.com/giangrg/RoboSim/blob/master/RoboSim/Resources/RoboIcon.ico "Logo")

### I. Description
This is a simple Toy Robot Simulator application made using C#.Net and WinForms.

### II. Import Commands
One of the important features of this application is the ability to import text files containing a list of commands. The accepted commands are as follows:
- `PLACE X,Y,F`: put the robot on the table in position X,Y and facing F (North, South, East, or West)
- `MOVE`: move the robot one unit forward in the direction it is currently facing
- `LEFT` & `RIGHT`: rotate the robot 90 degrees in the specified direction without changing the position of the robot
- `REPORT`: announce the X,Y and F of the robot.

**Example:**
```
PLACE 2,2,South
MOVE
LEFT
REPORT
```
