﻿namespace LabSystem.Abstracts
{
    public abstract class A_User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        // TODO: przerobic na ENUM ? 
        public string AccountType { get; set; }

    }
}