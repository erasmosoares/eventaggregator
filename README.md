# Event Aggregator
Decoupled Communication with an Event Aggregator

# How it Works
An Event Aggregator is a simple element of indirection. In its simplest form you have it register with all the source objects you are interested in, and have all target objects register with the Event Aggregator. The Event Aggregator responds to any event from a source object by propagating that event to the target objects.

The simplest Event Aggregator aggregates events from multiple objects into itself, passing that same event onto its observers. An Event Aggregator can also generalize the event, converting events that are specific to a source object into a more generic event. That way the observers of the aggregators don't need to register for as many individual event types. This simplifies the registration process for observers, at the cost of being notified of events that may not have any material effect on the observer.

# When to Use It
Event Aggregator is a good choice when you have lots of objects that are potential event sources. Rather than have the observer deal with registering with them all, you can centralize the registration logic to the Event Aggregator. As well as simplifying registration, a Event Aggregator also simplifies the memory management issues in using observers.

Learn more here https://www.martinfowler.com/eaaDev/EventAggregator.html

