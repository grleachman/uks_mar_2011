using System.Collections.Generic;
using developwithpassion.specifications.rhino;
using Machine.Specifications;
using nothinbutdotnetstore.web.core;
using developwithpassion.specifications.extensions;

namespace nothinbutdotnetstore.specs
{   
    public class PayloadBuilderSpecs
    {
        public abstract class concern : Observes<PayloadBuilder<ItemWithProperty>,DefaultPayloadBuilder<ItemWithProperty>>
        {
        
        }

        [Subject(typeof(PayloadBuilderSpecs))]
        public class when_with_detail_is_called_against_a_property_type : concern
        {

            Establish e = () =>
            {
                an_accessor = an<PropertyAccessor<ItemWithProperty, BlahPropertyType>>();
            };

            Because b = () =>
            {
               result =  sut.with_detail(an_accessor);
            };

            It should_store_the_accessor_in_its_token = () =>
                result.ShouldBeAn<PayloadBuilder<ItemWithProperty>>();

            static PropertyAccessor<ItemWithProperty,BlahPropertyType> an_accessor;

            static PayloadBuilder<ItemWithProperty> result;

        }
        public class BlahPropertyType{}}
    public class ItemWithProperty
    {
    }
}
