﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeoIS.Models
{
    class User
    {
        public User(string documentNumber, string password, string lastName, string name, string patronymic, DateTime dateOfBirth, string addres, string category, string gender, string city, string phoneNumber, string email, string userStatus)
        {
            DocumentNumber = documentNumber;
            Password = password;
            LastName = lastName;
            Name = name;
            Patronymic = patronymic;
            DateOfBirth = dateOfBirth;
            Addres = addres;
            Category = category;
            Gender = gender;
            City = city;
            PhoneNumber = phoneNumber;
            Email = email;
            UserStatus = userStatus;
        }

        public string DocumentNumber { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Addres { get; set; }
        public string Category { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string UserStatus { get; set; }
    }
}