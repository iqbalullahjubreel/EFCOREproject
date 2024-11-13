public interface IPizzaService
{
    void DeleteNewPizza(int id);

    PIZZA AddNewPizza(PizzaRequestModel requestModel);

    PIZZA UpdatePizza(PIZZA model);

    List<PIZZA> GetAllPizza();

    PIZZA GetPizza(int id);
}