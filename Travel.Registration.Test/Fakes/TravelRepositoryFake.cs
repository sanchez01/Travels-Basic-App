using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using Travel.Data.Abstract;
using Travel.Models.Registration;

namespace Travel.Registration.Test.Fakes
{
    public class TravelRepositoryFake : ITravelRepository
    {
        private List<Models.Registration.Travel> _travels;

        public TravelRepositoryFake()
        {
            _travels = new List<Models.Registration.Travel>();
        }

        public void Add(Models.Registration.Travel entity)
        {
            _travels.Add(entity);
        }

        public Models.Registration.Travel Get(Expression<Func<Models.Registration.Travel, bool>> predicate)
        {
            return _travels.FirstOrDefault(predicate.Compile());
        }

        public IEnumerable<Models.Registration.Travel> Where(Expression<Func<Models.Registration.Travel, bool>> predicate)
        {
            return _travels.Where(predicate.Compile());
        }
    }
}
