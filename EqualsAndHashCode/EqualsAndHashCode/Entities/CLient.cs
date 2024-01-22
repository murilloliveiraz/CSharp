namespace EqualsAndHashCode.Entities
{
    internal class CLient
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is CLient)) return false;
            CLient other = obj as CLient;
            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
