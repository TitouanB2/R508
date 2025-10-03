﻿namespace App.DTO
{
    public partial class TypeProductDTO
    {
        public int Id { get; set; }

        public string? Name { get; set; }
        
        
        public override bool Equals(object? obj)
        {
            return obj is TypeProductDTO dTO &&
                   Id == dTO.Id &&
                   Name == dTO.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}
