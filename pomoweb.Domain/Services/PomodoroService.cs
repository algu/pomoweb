using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using pomoweb.Domain.Entities;
using pomoweb.Domain.Repositories;

namespace pomoweb.Domain.Services
{
    public class PomodoroService : BaseService<Pomodoro>, IPomodoroService
    {
        public PomodoroService(IRepository<Pomodoro> pomodoroRepository, IUnitOfWork unitOfWork)
            : base(pomodoroRepository, unitOfWork)
        {

        }

        public void Add(string name, int estimate)
        {
            Add(new Pomodoro() { Name=name, Estimate = estimate, UserId = 1});
        }

        public void Update(int id, string name, int estimate)
        {
            var pomo = GetById(id);
            pomo.Name = name;
            pomo.Estimate = estimate;
            Update(pomo);
        }
    }

    public interface IPomodoroService : IService<Pomodoro>
    {
        void Add(string name, int estimate);
        void Update(int id, string name, int estimate);
    }
}
