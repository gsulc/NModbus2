NModbus
=======

NModbus2 is a C# implementation of the Modbus protocol.
Provides connectivity to Modbus slave compatible devices and applications.
Supports serial ASCII, serial RTU, TCP, and UDP protocols.
Retains connection information, and attempts to reconnect if the connection is lost.

History
=======

The NModbus project appears to have gone quiet. This is a fork of that project.

- NModbus2 is a fork of NModbus (https://github.com/NModbus/NModbus).
- NModbus is a fork of NModbus4 (https://github.com/NModbus4/NModbus4).
- NModbus4 is fork of NModbus(https://code.google.com/p/nmodbus).

NModbus differs from NModbus4 in following:

- Modbus slave devices are now added to a network which is represented by `IModbusSlaveInstance`.
- Heavier use of interfaces.
- Custom function code handlers can be added to slave devices.


Goals
=======
- Reduce the effort to maintain connectivity (eg. when disconnected, try to create a new connection).

Install
=======

To install NModbus, run the following command in the Package Manager Console

    PM> Install-Package NModbus2

Documentation
=======
Documentation is available in chm format (NModbus.chm)

License
=======
NModbus is licensed under the [MIT license](LICENSE.txt).
