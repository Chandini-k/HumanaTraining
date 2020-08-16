using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConstructorInjection
{
    public class Client
    {
        private IService _service;
        public Client(IService service)
        {
            this._service = service;
        }
        public Client() { this._service.Serve(); }
    }
}
