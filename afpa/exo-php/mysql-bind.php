<?php
$servername = "localhost";
$username = "angela";
$password = "angela";
$database = "employees";

// Create connection to database
$conn = new mysqli($servername, $username, $password, $database);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}
echo "Connected successfully";



// hey you, connection, yeah, dont look aside you. Execute this query. yes you. 
$result = $conn -> query("SELECT * FROM `departments`;");
if($result == 0) {
    die (mysqli_error($conn));
}

if ($result->num_rows > 0) {
    // output data of each row
	// fetch_assoc = hey little, fetch next row
    while( ($row = $result->fetch_assoc()) != 0) {
        echo "id: " . $row["dept_no"]. " - Name: " . $row["dept_name"] . "<br>";
    }
} 

// close the connection from database

mysqli_close($conn);

?>