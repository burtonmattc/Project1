﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class iAppointmentRepository
    {
        public IQueryable<Appointment> Appointments { get; }
    }
}
