﻿namespace RH_PJ.Models.temps
{
    public class UserModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class Jwt
    {
        public string key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string Subject { get; set; }
    }

    public class UserLogin
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MobilePhonePrefix { get; set; }
        public string? MobilePhone { get; set; }
        public string? IMG { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public int? Gender { get; set; }
        public DateTime? BirthDay { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public int? RoleID { get; set; }
        public int? UserLevel { get; set; }
        public int? Status { get; set; }
        public double? Wallet { get; set; }
        public bool? IsNotReceiveMail { get; set; }
        public bool? IsOutCityCustomer { get; set; }
        public bool? IsActive { get; set; }
        public int? SaleID { get; set; }
        public string? SaleUsername { get; set; }
        public string Token { get; set; }
        public DateTime? CreateDate { get; internal set; }
    }

    public class AccountInfo
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? IMG { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public int? Gender { get; set; }
        public string BirthDay { get; set; }
        public string? Email { get; set; }
    }

    public class SignUpModel
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string FirstName { get; set; }
        public string MiddName { get; set; }
        public string LastName { get; set; }
        public string BirthDay { get; set; }
        public int Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string? MobilePhonePrefix { get; set; }
        public string? MobilePhone { get; set; }
        public string? IMG { get; set; }
        public string? Latitude { get; internal set; }
        public string? Longitude { get; internal set; }
    }
}
