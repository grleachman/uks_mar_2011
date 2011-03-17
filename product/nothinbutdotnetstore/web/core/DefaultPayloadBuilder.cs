using System;
using System.Collections.Generic;

namespace nothinbutdotnetstore.web.core
{
    public class DefaultPayloadBuilder<ItemWithProperty> : PayloadBuilder<ItemWithProperty>
    {
        private TokenStore token_store;
        public PayloadBuilder<ItemWithProperty> with_detail<PropertyType>(PropertyAccessor<ItemWithProperty, PropertyType> accessor)
        {
            token_store.add(new KeyValuePair<string,object>("", accessor));
            return this;
        }
    }
}