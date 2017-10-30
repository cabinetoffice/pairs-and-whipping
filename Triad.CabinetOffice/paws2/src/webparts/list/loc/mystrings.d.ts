declare interface IListWebPartStrings {
  PropertyPaneDescription: string;
  BasicGroupName: string;
  TitleFieldLabel: string;
  CreateNewText: string;
  ItemsUrlFieldLabel: string;
  ItemsUrlFieldDescription: string;
  NamePropertyFieldLabel: string;
  DescriptionPropertyFieldLabel: string;
}

declare module 'ListWebPartStrings' {
  const strings: IListWebPartStrings;
  export = strings;
}
