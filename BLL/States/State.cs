using BLL.Contracts;
using BLL.Services;
using Domain;

namespace BLL.States
{
    public abstract class State
    {
        protected IParlanteService Parlante = new ParlanteService();
        public abstract void Disparar(Robot Robot);
    }
}
