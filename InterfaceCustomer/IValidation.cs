namespace InterfaceCustomer
{
    //Design Pattern:- Stratergy pattern (It helpes to choose validation dynamicaly)
    public interface IValidation<AnyType>
    {
        void Validate(AnyType obj);
    }
}
