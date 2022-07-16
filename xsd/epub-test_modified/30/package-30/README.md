# Note
`package-30.xsd` is modified to pass `xsd.exe`.

* The group "opf.meta" is referenced only by one. So it's embedded.
* The xsd.exe couldn't comprehend the following. So it's simplified.
  * It's not perfect in that both can occur only 0 now, which is not good.
* Some fix for xsd.exe's [limitation](https://social.msdn.microsoft.com/forums/en-US/707c8a47-a29f-4262-b052-ac66dc99d604/nested-xml-attribute-groups?forum=asmxandxml&prof=required).

```XSD
      <xs:choice>
        <xs:element maxOccurs="unbounded" ref="opf:collection"/>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" ref="opf:collection"/>
          <xs:group maxOccurs="unbounded" ref="opf:opf.collection.link"/>
        </xs:sequence>
      </xs:choice>
```
