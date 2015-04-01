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
- CustomerFindAll.xml [Request](CPSMv11APINervoGrid/Requests/CustomerFindAll.xml) [Response](CPSMv11APINervoGrid/Responses/CustomerFindAll.xml) => Find every customer accessible 
- CustomerFind.xml [Request](CPSMv11APINervoGrid/Requests/CustomerFind.xml) [Response](CPSMv11APINervoGrid/Responses/CustomerFind.xml) => Find every customer match the criteria (name, id, fullname, primarydomain, status, ...)
- CustomerGet.xml  [Request](CPSMv11APINervoGrid/Requests/CustomerGet.xml) [Response](CPSMv11APINervoGrid/Responses/CustomerGet.xml) => Get information about a specific customer
- CustomerGetProperties.xml [Request](CPSMv11APINervoGrid/Requests/CustomerGetProperties.xml) [Response](CPSMv11APINervoGrid/Responses/CustomerGetProperties.xml) => Get precise information about a specific customer
- CustomerCreate.xml [Request](CPSMv11APINervoGrid/Requests/CustomerCreate.xml) [Response](CPSMv11APINervoGrid/Responses/CustomerCreate.xml) => Information required to create a customer
- CustomerModify.xml [Request](CPSMv11APINervoGrid/Requests/CustomerModify.xml) [Response](CPSMv11APINervoGrid/Responses/CustomerModify.xml) => Modify customer properties
- CustomerServicesFindAll.xml [Request](CPSMv11APINervoGrid/Requests/CustomerServicesFindAll.xml) [Response](CPSMv11APINervoGrid/Responses/CustomerServicesFindAll.xml) => Find every available customer's service
- CustomerProvisionExchange.xml  [Request](CPSMv11APINervoGrid/Requests/CustomerProvisionExchange.xml) [Response](CPSMv11APINervoGrid/Responses/CustomerProvisionExchange.xml) => Provision Exchange to a customer. Required: version, customerplan(package) and userplan(userpackage)
- CustomerServiceGet.xml [Request](CPSMv11APINervoGrid/Requests/CustomerServiceGet.xml) [Response](CPSMv11APINervoGrid/Responses/CustomerServiceGet.xml) => Get information about a specific customer's service
- CustomerModifyExchange.xml [Request](CPSMv11APINervoGrid/Requests/CustomerModifyExchange.xml) [Response](CPSMv11APINervoGrid/Responses/CustomerModifyExchange.xml) => Modify Exchange properties. Exemple: Set authoritative domain and create public folders
- UserCreate.xml [Request](CPSMv11APINervoGrid/Requests/UserCreate.xml) [Response](CPSMv11APINervoGrid/Responses/UserCreate.xml) => Information required to create a user
- UserGet.xml [Request](CPSMv11APINervoGrid/Requests/UserGet.xml) [Response](CPSMv11APINervoGrid/Responses/UserGet.xml) => Get information about a specific user
- UserGetProperties.xml [Request](CPSMv11APINervoGrid/Requests/UserGetProperties.xml) [Response](CPSMv11APINervoGrid/Responses/UserGetProperties.xml) => Get precise information about a specific user
- UserServicesFindAll.xml [Request](CPSMv11APINervoGrid/Requests/UserServicesFindAll.xml) [Response](CPSMv11APINervoGrid/Responses/UserServicesFindAll.xml) => Find every available user's service
- UserProvisionExchange.xml [Request](CPSMv11APINervoGrid/Requests/UserProvisionExchange.xml) [Response](CPSMv11APINervoGrid/Responses/UserProvisionExchange.xml) => Provision Exchange to a user. Required: userplan(userpackage)
- UserServiceGet.xml [Request](CPSMv11APINervoGrid/Requests/UserServiceGet.xml) [Response](CPSMv11APINervoGrid/Responses/UserServiceGet.xml) => Get information about a specific user's service
- CustomerDistributionGroupsGet
- DistributionGroupAddMember
- UserDeprovisionExchange
- UserDeprovision
- UserDelete
- CustomerDeprovisionExchange
- CustomerDeprovision
- CustomerDelete

## Status Request
When sending a request and server provisioning is necessary, a server request is created and the API responds with a request ID. (Example Response: [CustomerProvisionExchange.xml](CPSMv11APINervoGrid/Responses/CustomerProvisionExchange.xml))
The server request status can be queried using the request GetRequest.xml[Request](CPSMv11APINervoGrid/Requests/GetRequest.xml)[Response](CPSMv11APINervoGrid/Responses/GetRequest.xml).

The request status can be :
- NotProvisioned
- Requested
- InProgress
- Provisioned
- Failed
- Pending
