public interface IPizzaRepository
{
    PIZZA AddPizza(PIZZA pizza);
    void DeletePizza(int id);
    PIZZA UpdatePizza(PIZZA pizza);
    List<PIZZA> GetAllPizza();
    PIZZA GetPizza(int Id);
}
