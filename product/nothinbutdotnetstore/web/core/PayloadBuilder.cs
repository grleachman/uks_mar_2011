namespace nothinbutdotnetstore.web.core
{
    public interface PayloadBuilder<ItemWithProperty>
    {
        PayloadBuilder<ItemWithProperty> with_detail<PropertyType>(PropertyAccessor<ItemWithProperty, PropertyType> accessor);
    }
}