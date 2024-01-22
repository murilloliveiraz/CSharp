namespace setExercise.Entities
{
    internal class Student
    {
        public int codeID { get; set; }

        public Student(int codeID)
        {
            this.codeID = codeID;
        }

        public override int GetHashCode()
        {
            return codeID.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Student)) return false;
            Student other = (Student)obj;
            return codeID.Equals(other.codeID);
        }
    }
}
