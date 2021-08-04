# About this project

My firt example with .NET from [DIO](https://digitalinnovation.lt.acemlnb.com/Prod/link-tracker?redirectUrl=aHR0cHMlM0ElMkYlMkZ3ZWIuZGlnaXRhbGlubm92YXRpb24ub25lJTJGcHJvamVjdCUyRmNyaWFuZG8tdW0tYXBwLWRlLWNhZGFzdHJvLWVtLW1lbW9yaWEtaW1wbGVtZW50YW5kby1jcnVkLWRlLXNlcmllcy1lbS1uZXQlMkZsZWFybmluZyUyRjcxYjA2NWE1LTQ4MWUtNGViMS05YTRhLTMxZmUzM2FmZDZjYSUzRmJhY2slM0QlMkZ0cmFjayUyRmF2YW5hZGUtY29kZWFueXdoZXJlLW5ldA==&a=475833027&account=digitalinnovation%2Eactivehosted%2Ecom&email=wFYJcDVJlRSDyMW9ex2%2BVr35hO7C%2FF3J%2FgQB9Uu3XAY%3D&s=c74c9f26e01f894e50d4b2f1bfa34df9&i=4063A4314A139A48692)

![](https://img.shields.io/badge/by-DIO-informational?style=flat&logoColor=white&color=fa962a)
![](https://img.shields.io/badge/student-Alejandro.Fuentes-informational?style=flat&logoColor=white&color=cdcdcd)
![](https://img.shields.io/badge/Editor-Visual_Studio_Code-informational?style=flat&logo=Visual-Studio-Code&logoColor=white&color=007acc) 
![](https://img.shields.io/badge/Code-.net-informational?style=flat&logo=.net&logoColor=white&color=512bd4) 

### Steps
For create our project, we can execute next command:

```
$ dotnet new console -n NomeProject
```

Next, we can open it with VSC, from inner path with project:

```
$ code .
```

For execute this example that command *dotnet* created for us, can use next command:

```
$ dotnet run
```

### Wath is our ideia

Using one interface Desing Patter, we desing our repository, where has the way to store we datas.

```
public interface IRepository<T> 
{
    ...
}

```

Next implement in our class of entity:

```
public class Serie : EntidadeBase
{
    ...
}
```


And now, implement our class that  manage this entity:


```
public class SerieRepository : IRepository<Serie>
{
    ...
}

```
