Feature: US0003 Customer information
	As a rehabilitation specialist
	I want to register my clients
	So that I can know the total number of clients I have had

Scenario: Complete the requested information
	Given the rehabilitation specialist is in the New Customer view
	When enters the requested data: <description> and <userId>
	And clicks the button save
	Then the system registers the customer information

	Examples: 
	| description																   | userId |
	| Diagnóstico de Jorge Perez: Ha sufrido una lesión en la rodilla izquierda... | 1	    |
	| Diagnóstico de Claudia Sánchez: Dislocación del hombro derecho...            | 2      |

Scenario: Edit the customer information
	Given the rehabilitation specialist is in the Customer view
	When edits the customer information: <description> and <userId>
	And clicks button Save
	Then the system save changes made

	Examples: 
	| description											   | userId |
	| Diagnóstico de Jorge Perez: Se aplicaron tratamientos... | 1	    |