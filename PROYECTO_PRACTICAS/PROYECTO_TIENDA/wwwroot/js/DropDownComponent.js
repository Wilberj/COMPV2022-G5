export default function CreateDropDown(Dataset = [],
    Select,
    Value = "",
    Display = "",
    SelectFunction) {
    if (SelectFunction) {
        Select.onchage = SelectFunction;
    }
    Dataset.forEach((item, index) => {
        const Options = document.createElement("option");
        Options.innerText = item[Display];
        Options.value = item[Value];
        Select.append(Options);
    });
}