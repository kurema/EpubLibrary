# Note
`package-30.xsd` is modified to pass `xsd.exe`.

* The group "opf.meta" is referenced only by one. So it's embedded.
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
62c62,66
< 			<!-- Modification from here -->
---
>       <xs:group ref="opf:opf.meta"/>
>       <xs:group ref="opf:opf.link"/>
>     </xs:choice>
>   </xs:complexType>
>   <xs:group name="opf.meta">
89,93c93
< 			<!-- To here -->
< 			<xs:group ref="opf:opf.link"/>
< 		</xs:choice>
< 	</xs:complexType>
< 
---
>   </xs:group>
329c329,330
< 			<!-- Not perfect from here -->
---
>       <xs:choice>
>         <xs:element maxOccurs="unbounded" ref="opf:collection"/>
332c333
< 				<xs:group minOccurs="0" maxOccurs="unbounded" ref="opf:opf.collection.link"/>
---
>           <xs:group maxOccurs="unbounded" ref="opf:opf.collection.link"/>
334c335
< 			<!-- To here -->
---
>       </xs:choice>
```