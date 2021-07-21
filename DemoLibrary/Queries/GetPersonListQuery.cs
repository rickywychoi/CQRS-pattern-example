using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Queries
{
    public record GetPersonListQuery() : IRequest<List<Person>>;

    //// record can be used here since we only need readibility of class.
    //public class GetPersonListQuery : IRequest<List<Person>>
    //{
    //    public GetPersonListQuery() { }
    //}
}
