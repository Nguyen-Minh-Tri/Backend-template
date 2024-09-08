# Backend-template

Back-end concept for DDD - simplify version:
	+ Domain driven design mainly focus on to separate the concept of how our application express to other system and internal logics.
	+ Normally this design can be splitted into three main categories which are: presentation layer, domain layer and infrastructure layer.
	+ Each layer of domain driven design focus on In - Process - Out flow, and it prevent the system to not overlapping others functionalities.

Presentation layer:
	+ Role: Bridging the gap between domain layer and outside world, dealing with users or external systems and client applications.
	+ Possible input: Client/user/external-system requests and translate these requests to data form that domain layer can understand.
	+ Possible output: return results that can be present to user, technically speaking it's more user friendly (e.g., JSON, HTML...).
		- JSON, GRPC or XML... are formats that can be serve from WebApi/WebService.
		- HTLM are rendered by server side render, which typically a kind of web application. Server render normally suitale with enterprise applications because of quick update, quick render and flexibilities when integrate with domain layer.
	+ Related concepts: Author/authen; Pre-domain validation; Data transfer object.	
		
Domain layer - the heart of DDD architect:
	+ Role: handle all main logic(domain service), this is the space for our problems, you would hold all of your entities in here, bring all the logic and process to handle inside domain layer help you to separate the concern with other guys like database and UI.
	+ Domain service: people usually call the place for handling main business is service something(e.g., UserService provide check get/set user data), dev might also call it logic provider. If you expect something to change, or to check multiple tables and get a result, then you should touch this guy. And, if you just want to get some data, the presentation layer should be able to call directly to database access inside repository layer.
	+ Entities: encapsulate business meaning, also manipualte rule and behaviour if we know how to manipulate their states appropriately.
	+ Related concepts: Value object, Aggregates, Domain Event, Factory
	
Infrastructure Layer:

	+ Repositories: Responsible for persisting and retrieving aggregates and entities from storage (e.g., databases).
	+ Message Handlers: Deal with communication to external systems (e.g., sending emails, handling messages from a message queue).
	+ Third-party Services: Integrations with external systems like payment gateways, cloud services, etc.