﻿using DataLayer.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.UnitOfWork
{
    /// <summary>
    /// This is the main unitofwork that receives saved data, distributes the data and saves new data
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;

        public IEmployeeRepository Employees { get; }
        public IInsuranceRepository Insurances { get; }
        public IInsuranceTakerRepository InsuranceTakers { get; }
        public IInsuredPersonRepository InsuredPersons { get; }
        public IPersonRepository Persons { get; }
        public ICompanyRepository Companies { get; }

        public IAccessRepository Accesses { get; }

<<<<<<< HEAD
        public IBaseAmountTableRepository Tables { get; }

=======
        public IBaseAmountRepository BaseAmounts { get; }
        public IOptionalTypeRepository OptionalTypes { get; }

       
>>>>>>> 47e5c7287f62c6b47373f1be8f6ce98bf184d8c8
        public UnitOfWork()
        {
            _context = new ApplicationContext();
            Employees = new EmployeeRepository(_context);
            Insurances = new InsuranceRepository(_context);
            InsuranceTakers = new InsuranceTakerRepository(_context); 
            InsuredPersons = new InsuredPersonRepository(_context);
            Persons = new PersonRepository(_context);
            Companies = new CompanyRepository(_context);
            Accesses = new AccessRepository(_context);
<<<<<<< HEAD
            Tables = new BaseAmountTableRepository(_context);
=======
            BaseAmounts = new BaseAmountRepository(_context);
            OptionalTypes = new OptionalTypeRepository(_context);
>>>>>>> 47e5c7287f62c6b47373f1be8f6ce98bf184d8c8
            Init();
        }
        public void Init() => _context.Reset();
        public int Complete() => _context.SaveChanges();

        public void Dispose() => _context.Dispose();
        
    }
}
