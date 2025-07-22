# TagAttribute

TagAttributeは、Unityのインスペクター上でタグ選択を簡単に行えるカスタム属性です。  
`Tag`属性をフィールドに付与することで、タグ名を直接入力するのではなく、プルダウンから選択できるようになります。

![Image](https://github-production-user-asset-6210df.s3.amazonaws.com/124390814/468930155-2e4b560c-7270-4f55-ba0e-d1b749eb5457.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAVCODYLSA53PQK4ZA%2F20250722%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20250722T030410Z&X-Amz-Expires=300&X-Amz-Signature=9bcbffb0935cb0f44525b3a95fedcc757df400711f52eb398f6b959d0e109e0f&X-Amz-SignedHeaders=host)

## 特長

- Unityエディターのインスペクターでタグ選択が可能
- `string`型や`List<string>`型のフィールドに対応
- 入力ミスを防ぎ、タグ管理を効率化

## 使用例

```csharp
[SerializeField, Tag]
private string tagName;

[SerializeField, Tag]
private List<string> tagNameList;
```


上記のように、`Tag`属性を付与したフィールドはインスペクター上でタグ選択が可能になります。
