# blazor-sample
Blazorの CRUD サンプル

## Feature
- .NET Core 3.0
- Blazor
- AutoMapper
- PWA

## Project Configuration
- BlazorSample.Client
    - フロントエンドのプロジェクト
- BlazorSample.Server
    - サーバサイドのプロジェクト
- BlazorSample.Shared
    - フロント・サーバ共有クラスのプロジェクト

## Note
- Blazorを使ったCRUDのSPAサンプルです。
- ASP.NET MVCっぽく ViewModel を利用しデータのやり取りを行います。
- PWAに対応しています。httpsでアクセス後、PWA対応ブラウザでアクセスしてください。
- データストアにLocal DBが必要です。BlazorSample.Serverにマイグレーションコードを記載しています。

## Reference
- https://github.com/AnkitSharma-007/ASPCore.BlazorCrud
- https://github.com/krdmllr/DotnetPwaSample