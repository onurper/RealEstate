﻿namespace Api.Dtos.ServiceDtos
{
    public class UpdateServiceDto
    {
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}