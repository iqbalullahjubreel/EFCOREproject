
using EFCOREproject.Migrations;

public class Pizzaservice : IPizzaService
{
    private readonly IPizzaRepository _context;
    public Pizzaservice(IPizzaRepository context)
    {
        _context = context;
    }
    public PIZZA AddNewPizza(PizzaRequestModel requestModel)
    {
        PIZZA pizzas = new PIZZA();
        pizzas.Name = requestModel.Name;
        pizzas.Description = requestModel.Description;
        pizzas.IsAvailable = requestModel.IsAvailable;
        return _context.AddPizza(pizzas);
    }

    public void DeleteNewPizza(int id)
    {
        PIZZA pi = _context.GetPizza(id);
        _context.DeletePizza(pi.Id);
    }

    public List<PIZZA> GetAllPizza()
    {
        return _context.GetAllPizza();
    }

    public PIZZA GetPizza(int id)
    {
        PIZZA pizz = _context.GetPizza(id);
        return pizz;
    }

    public PIZZA UpdatePizza(PIZZA model)
    {
        _context.UpdatePizza(model);
        return model;
    }
}
