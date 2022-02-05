# BestCloudAcademy
## Uygulama nasıl build ediir?
Öncelikle proje dosyası indirilmelidir. Ardından Dockerfile dosyasının olduğu dizinde komut satırı çalıştırılmalıdır.
Daha sonraki aşamada ise aşağıdaki komutlar çalıştırılmalıdır:
```
docker build -t "ImageName" .
docker run -d -p 5000:4500 "ImageName"
```

### Uygulama endpoinlerine nasıl erişilir?
Herhangi bir tarayıcıda aşağıdaki linklere gidilmelidir?
- http://localhost:5000
- http://localhost:5000/temperature?city=" şehir adı"
