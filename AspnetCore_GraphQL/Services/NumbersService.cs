using AspnetCore_GraphQL.IService;
using AspnetCore_GraphQL.Models;
using AspnetCore_GraphQL.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore_GraphQL.Services
{
    public class NumbersService : IService.INumbersService
    {
        private IList<Numbers> _numbers;


        //TODO Construtor com placeholder
        public NumbersService()
        {
            Random random = new Random();
            _numbers = new List<Numbers>();
            for (int i = 0; i <= 3; i++)
            {
                _numbers.Add(
                    new Numbers()
                    {
                        Target = random.Next(1,42),
                        Range = new int[] { 1, 2, 3, 4, 5 }
                    });
            }
        }

        public int[] Create(CreateNumbersInput numbersInput)
        {
            Numbers number = new Numbers
            {
                Target = numbersInput.Target,
                Range = numbersInput.Range
            };
            _numbers.Add(number);
            return NumbersCalc.Calculate(number.Range, number.Target);
        }

        public IQueryable<Numbers> GetAll()
        {
            return _numbers.AsQueryable();
        }

    }
}
