export default function CreateTable(Dataset = [], Table, TableFunction, BtnValue = "Edit") {
    const thead = Table.querySelector("thead"); //dataset= response, table=nombre de la tabla-tableproducto,?,?
    const tbody = Table.querySelector("tbody");//tbody = cuerpo de tabla, thead=encabezado de tabla
    
    thead.innerHTML = "";
    tbody.innerHTML = "";
    //const contenedor = document.createElement("div");
    //contenedor.className = "divcontenedor";


    Dataset.forEach((item, index) => {
        const row = document.createElement("tr");//filas
        for (var prop in item) {

            if (index == 0) {

                const th = document.createElement("th");//encabezados
                th.innerText = prop;
                thead.append(th);
            }
            const td = document.createElement("td"); //tabledata
            td.innerText = item[prop];
            row.append(td);
        }
        if (index == 0) {
            const th = document.createElement("th");
            th.innerText = "Action";
            thead.append(th);

        }
        const tdAction = document.createElement("td");
        const btn = document.createElement("input");
        btn.type = "button";
        btn.className = "BTN BTNOK";
        btn.value = BtnValue;
        btn.onclick = () => {
            //console.log(item);
            TableFunction(item);
        }
        tdAction.append(btn);
        row.append(tdAction);
        tbody.append(row);
        //contenedor.append(filter, Table);
    });

}