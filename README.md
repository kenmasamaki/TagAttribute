# TagAttribute

TagAttributeは、Unityのインスペクター上でタグ選択を簡単に行えるカスタム属性です。  
`Tag`属性をフィールドに付与することで、タグ名を直接入力するのではなく、プルダウンから選択できるようになります。

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
