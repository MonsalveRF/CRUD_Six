using CRUD_SixD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUD_SixD.Controllers
{
    public class UsuarioController : ApiController
    {
        // GET: api/Usuario
        public IEnumerable<Usuario> Get()
        {
            GestorUsuario gUsuario = new GestorUsuario();
            return gUsuario.getUsuario();
        }

        // GET: api/Usuario/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Usuario
        public bool Post(int id,[FromBody] Usuario usuario)
        {
            GestorUsuario gUsuario = new GestorUsuario();
            bool rta = gUsuario.AddUsuario(id,usuario);

            return rta;
        }

        // PUT: api/Usuario/5
        public bool Put(int id, [FromBody] Usuario usuario)
        {
            GestorUsuario gUsuario = new GestorUsuario();
            bool rta = gUsuario.UpdateUsuario(id,usuario);

            return rta;
        }

        // DELETE: api/Usuario/5
        public bool Delete(int id)
        {
            GestorUsuario gUsuario = new GestorUsuario();
            bool rta = gUsuario.DeleteUsuario(id);

            return rta;
        }
    }
}
