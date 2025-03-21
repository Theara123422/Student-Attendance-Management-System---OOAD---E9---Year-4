namespace Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Command.Attendances
{
    public class AttendanceInvoker
    {
        private ICommands _command;
        public void SetCommand(ICommands command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command?.Execute();
        }
    }
}
