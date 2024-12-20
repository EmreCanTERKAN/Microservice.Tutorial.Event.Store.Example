using EventStore.Client;

string connectionString = "tcp://admin:changeit@localhost:1113";

var settings = EventStoreClientSettings.Create(connectionString);

//bağlantıyı sağlayacak olan clienti oluşturduk.
var client = new EventStoreClient(settings);