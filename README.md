# CPSMv11APINervoGrid
[Citrix CloudPortal Services Manager](https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=1&cad=rja&uact=8&ved=0CB0QFjAA&url=http%3A%2F%2Fwww.citrix.com%2Fproducts%2Fcloudportal-services-manager%2Foverview.html&ei=TZASVc-_HYKLaMCDgbgM&usg=AFQjCNGbdsOjhikhGm4huacReiqf5tzbFQ&sig2=o125heJONSem2lRIDRslDQ) API Samples for NervoGrid

## Program
This program lets you send request to the Citrix CloudPortal Services Manager API hosted by [Global SP](http://www.globalsp.com/).

## Sending requests
The requests are sent as XML files and responses are received as XML files.

## Results 
Requests can be found under the [Requests](CPSMv11APINervoGrid/Requests/) directory.  
Responses can be found under the [Responses](CPSMv11APINervoGrid/Responses/) directory.  

## Requests
- [CustomerFindAll.xml](CPSMv11APINervoGrid/Requests/CustomerFindAll.xml) => Find every customer accessible
- [CustomerFind.xml](CPSMv11APINervoGrid/Requests/CustomerFind.xml) => Find every customer match the criteria (name, id, fullname, primarydomain, status, ...)
- [CustomerGet.xml](CPSMv11APINervoGrid/Requests/CustomerGet.xml) => Get information about a specific customer
- [CustomerGetProperties.xml](CPSMv11APINervoGrid/Requests/CustomerGetProperties.xml) => Get precise information about a specific customer
- [CustomerCreate.xml](CPSMv11APINervoGrid/Requests/CustomerCreate.xml) => Information required to create a customer
- [CustomerModify.xml](CPSMv11APINervoGrid/Requests/CustomerModify.xml) => Modify customer properties
- [CustomerServicesFindAll.xml](CPSMv11APINervoGrid/Requests/CustomerServicesFindAll.xml) => Find every available customer's service
- [CustomerProvisionExchange.xml](CPSMv11APINervoGrid/Requests/CustomerProvisionExchange.xml) => Provision Exchange to a customer. Required: version, customerplan(package) and userplan(userpackage)
- [CustomerServiceGet.xml](CPSMv11APINervoGrid/Requests/CustomerServiceGet.xml) => Get information about a specific customer's service
- [CustomerModifyExchange.xml](CPSMv11APINervoGrid/Requests/CustomerModifyExchange.xml) => Modify Exchange properties. Exemple: Set authoritative domain and create public folders
- [UserCreate.xml](CPSMv11APINervoGrid/Requests/UserCreate.xml) => Information required to create a user
- [UserGet.xml](CPSMv11APINervoGrid/Requests/UserGet.xml) => Get information about a specific user
- [UserGetProperties.xml](CPSMv11APINervoGrid/Requests/UserGetProperties.xml) => Get precise information about a specific user
- [UserServicesFindAll.xml](CPSMv11APINervoGrid/Requests/UserServicesFindAll.xml) => Find every available user's service
- [UserProvisionExchange.xml](CPSMv11APINervoGrid/Requests/UserProvisionExchange.xml) => Provision Exchange to a user. Required: userplan(userpackage)
- [UserServiceGet.xml](CPSMv11APINervoGrid/Requests/UserServiceGet.xml) => Get information about a specific user's service
- CustomerDistributionGroupsGet
- DistributionGroupAddMember
- UserDeprovisionExchange
- UserDeprovision
- UserDelete
- CustomerDeprovisionExchange
- CustomerDeprovision
- CustomerDelete
