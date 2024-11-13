

using Microsoft.EntityFrameworkCore;

public class PizzaRepository : IPizzaRepository
{
    private readonly Context _context;
    public PizzaRepository(Context context)
    {
        _context = context;
    }
    public PIZZA AddPizza(PIZZA pizza)
    {
        _context.Pizzas.Add(pizza);
        _context.SaveChanges();
        return pizza;
    }

    public void DeletePizza(int id)
    {
        PIZZA? result = _context.Pizzas.FirstOrDefault(x => x.Id == id);
        _context.Pizzas.Remove(result);
        _context.SaveChanges();
    }

    public List<PIZZA> GetAllPizza()
    {
        List <PIZZA> pizza = _context.Pizzas.ToList();
        return pizza;
    }

    public PIZZA GetPizza(int id)
    {
        PIZZA? result = _context.Pizzas.FirstOrDefault(x => x.Id == id);
        return result;
    }

    public PIZZA UpdatePizza(PIZZA pizza)
    {
       _context.Pizzas.Update(pizza);
        return pizza;
        _context.SaveChanges();

    }
}
