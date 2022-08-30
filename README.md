# CharacterCollection-WebAPI

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![LinkedIn][linkedin-shield]][linkedin-url]


<br />

<h3 align="center">Character Collection WEB API</h3>



<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#screenshots">Screenshots</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>



## About The Project
WEB API for all Marvel characters. Explore Marvel superheroes and villans in this custom designed database.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



### Built With

* [![C#][CSharp.com]][CSharp-url]
* [![NETFramework][dotnet.com]][dotnet-url]
* [![MicrosoftSQLServer][sql.com]][sql-url]

<p align="right">(<a href="#readme-top">back to top</a>)</p>



## Getting Started

This is an example of how you may give instructions on setting up your project locally.
To get a local copy up and running follow these simple example steps.

### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/PaskoBerisic/CharacterCollection-WebAPI.git
   ```
2. Create database using Package Manager Console
   ```sh
   Update-Database
   ```
   Migrations for database are visible inside "Migrations" folder in "Infrastructure" project.

3. (Optional) <br>
   You can use separate Angular application for better expirience if you have issues working with Swagger.
   
   Clone the Angular App repo
   ```sh
   git clone https://github.com/PaskoBerisic/CharacterCollectionApp.git
   ```

<p align="right">(<a href="#readme-top">back to top</a>)</p>



## Usage

Use the predefined database with some of the Marvel characters or even extend the database with new characters. 
You Can preform CRUD operations with Swagger or Angular application using this Web API.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



## Screenshots

### Swagger Landing Page
``` http://localhost:44352/api/ ```
<br>
![first](https://user-images.githubusercontent.com/37916092/187413749-f4355d2e-c2a8-4633-98c3-c999e8b2cfe0.png)


### GET
``` http://localhost:44352/api/Hero ```
<br>
![get](https://user-images.githubusercontent.com/37916092/187413771-5412096d-f581-42a3-8baa-23fff60e46ec.png)


### POST
``` http://localhost:44352/api/Hero ```
<br>
![post](https://user-images.githubusercontent.com/37916092/187413794-19ac7363-d3de-47ca-9163-7403738a3105.png)


### PUT
``` http://localhost:44352/api/ ```
<br>
![put](https://user-images.githubusercontent.com/37916092/187413811-8b2d427e-7d19-48d7-a5ef-2f39a1d9c90f.png)


### DELETE
``` http://localhost:44352/api/Hero/{id} ```
<br>
![delete](https://user-images.githubusercontent.com/37916092/187413821-8219332b-0dc5-421e-b03b-07b7ad4619cc.png)




## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#readme-top">back to top</a>)</p>



## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



## Contact

Project Link: [https://github.com/PaskoBerisic/CharacterCollection-WebAPI](https://github.com/PaskoBerisic/CharacterCollection-WebAPI)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

[contributors-shield]: https://img.shields.io/github/contributors/PaskoBerisic/CharacterCollection-WebAPI.svg?style=for-the-badge
[contributors-url]: https://github.com/PaskoBerisic/CharacterCollection-WebAPI/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/PaskoBerisic/CharacterCollection-WebAPI.svg?style=for-the-badge
[forks-url]: https://github.com/PaskoBerisic/CharacterCollection-WebAPI/network/members
[stars-shield]: https://img.shields.io/github/stars/PaskoBerisic/CharacterCollection-WebAPI.svg?style=for-the-badge
[stars-url]: https://github.com/PaskoBerisic/CharacterCollection-WebAPI/stargazers
[issues-shield]: https://img.shields.io/github/issues/PaskoBerisic/CharacterCollection-WebAPI.svg?style=for-the-badge
[issues-url]: https://github.com/PaskoBerisic/CharacterCollection-WebAPI/issues
<!-- [license-url]: https://github.com/PaskoBerisic/CharacterCollection-WebAPI/main/LICENSE.txt -->
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://hr.linkedin.com/in/pasko-berisic
[product-screenshot]: images/screenshot.png
[Csharp.com]: https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white
[Csharp-url]: https://dotnet.microsoft.com/en-us/learn/csharp
[dotnet.com]: https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white
[dotnet-url]: https://dotnet.microsoft.com/
[sql.com]: https://img.shields.io/badge/Microsoft%20SQL%20Sever-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white
[sql-url]: https://www.microsoft.com/en-us/sql-server/sql-server-downloads
