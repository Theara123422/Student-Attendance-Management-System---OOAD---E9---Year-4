namespace Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Observer.Attendances
{

    public interface IAttendanceObserverSubject
    {
        void Subscribe(IAttendanceObserver observer); 
        void Unsubscribe(IAttendanceObserver observer);
        void NotifyObservers(); 
    }
}
