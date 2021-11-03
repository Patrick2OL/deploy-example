Feature: US0001 Create an user
	As a customer
	I want to register on the website
	So that I can access rehabilitation sessions or training programs

Scenario: Enter the registration view
	Given the user enters the <URL> of the web application
	And is in the home view
	When the user selects the user view option
	Then the system displays the user registration view

	Examples: 
	| URL                            |
	| https://terapic-96405.web.app/ |

Scenario: Complete the requested information
	Given the user is in the New User view
	When the user enters the requested data: <name>, <lastname>, <description>, <birth>, <address>, <phone>, <age>, <email>, <country>, <gender> and <password>
	And clicks save
	Then the system registers the user's account

	Examples: 
	| name | lastname | description             | birth      | address            | phone     | age | email                 | country | gender    | password |
	| Luis | Mendez   | Me gusta hacer deporte  | 11/11/1990 | Avenida La Alameda | 966314855 | 30  | luis.mendez@gmail.com | Perú    | masculino | rfLNWwn8 |
	| Paul | Flores   | Me gusta ir al gimnasio | 08/12/1994 | Jiron La Alameda   | 998298156 | 26  | paul.flores@gmail.com | Perú    | masculino | d96nfwj7 |