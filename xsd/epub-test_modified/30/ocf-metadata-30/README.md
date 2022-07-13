# Note
This is almost same as [package-30](../package-30/README.md)

`package-30.xsd` is modified to pass `xsd.exe`.

* The xsd.exe couldn't comprehend the following. So it's simplified.
  * It's not perfect in that both can occur only 0 now, which is not good.

```XSD
      <xs:choice>
        <xs:element maxOccurs="unbounded" ref="opf:collection"/>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" ref="opf:collection"/>
          <xs:group maxOccurs="unbounded" ref="opf:opf.collection.link"/>
        </xs:sequence>
      </xs:choice>
```

```diff
321a322,323
>       <xs:choice>
>         <xs:element maxOccurs="unbounded" ref="opf:collection"/>
325a328
>       </xs:choice>
```