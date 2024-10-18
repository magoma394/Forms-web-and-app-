import mysql.connector
from http.server import BaseHTTPRequestHandler, HTTPServer
from urllib.parse import parse_qs


class MyHandler(BaseHTTPRequestHandler):

    def do_GET(self):
        self.send_response(200)
        self.send_header('Content-type', 'text/html')
        self.end_headers()

        # Write HTML code to display the form
        html = '''<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8" />
    <link rel="stylesheet" href="globals.css" />
    <link rel="stylesheet" href="style.css" />
  </head>
  <body>
    <div class="HO-me">
      <div class="div">
        <div class="hesham">
          <p class="prof-dr-hesham">
            <span class="text-wrapper">Prof. Dr/ </span> <span class="span">Hesham Arafat</span>
          </p>
        </div>
        <div class="personal-info">
          <div class="patient-name-f">
            <div class="div-2"></div>
            <div class="text-wrapper-2">Patient Name</div>
          </div>
          <div class="gender-f">
            <div class="div-3"></div>
            <div class="text-wrapper-2">Gender</div>
          </div>
          <div class="age-f">
            <div class="div-3"></div>
            <div class="text-wrapper-2">Age</div>
          </div>
          <div class="patient-address-f">
            <div class="div-2"></div>
            <div class="text-wrapper-2">Patient Address</div>
          </div>
          <div class="contact-number">
            <div class="div-4"></div>
            <div class="text-wrapper-2">Contact Number</div>
          </div>
          <div class="doctor-name-f">
            <div class="div-2"></div>
            <div class="text-wrapper-2">Doctor Name</div>
          </div>
          <div class="final-result-f">
            <div class="div-4"></div>
            <div class="text-wrapper-3">Final Result</div>
          </div>
          <img class="submit-button" src="img/submit-button.png" />
        </div>
        
        <div class="prediction-frame">
          <div class="selected-image-frame"></div>
          <img class="upload-button" src="img/upload-button.png" />
          <img class="test-button" src="img/test-button.png" />
        </div>
        <div class="intro-frame">
          <p class="p">
            Hi.. We are “COD” team. We made this form so You can use it to diagnosis acute lymphocytic leukemia (ALL),
            and check if the state is positive or negative. We offer help by making it quick and automatic using
            Computer vision and Deep Learning.
          </p>
        </div>
        <div class="overlap">
          <div class="frame"><div class="head-background"></div></div>
          <img class="COD-logo" src="img/cod-logo.png" />
          <a href="https://ai.deltauniv.edu.eg/ar/home/index" target="_blank" rel="noopener noreferrer"
            ><div class="aidu-logo"></div
          ></a>
          <a href="https://new.deltauniv.edu.eg/ar/home/index" target="_blank" rel="noopener noreferrer"
            ><div class="group-du"></div
          ></a>
          <a
            href="https://www.cancercenter.com/cancer-types/leukemia/diagnosis-and-detection"
            target="_blank"
            rel="noopener noreferrer"
            ><div class="project-logo">
              <div class="overlap-group">
                <img class="leukemia" src="img/leukemia-1.png" />
                <div class="text-wrapper-4">Leukemia Detection</div>
              </div>
            </div></a
          >
        </div>
      </div>
    </div>
  </body>
</html>'''

        # Send the HTML code to the client
        self.wfile.write(bytes(html, 'utf-8'))
        return

    def do_POST(self):my
        # Get the form data
        content_length = int(self.headers['Content-Length'])
        post_data = self.rfile.read(content_length)
        post_data = post_data.decode('utf-8')
        form_data = parse_qs(post_data)
        Product = form_data['Product'][0]
        ExpiryDate = form_data['ExpiryDate'][0]
        _Price= form_data['_Price'][0]
        Amount= form_data['Amount'][0]

        # Insert the data into the database
        cnx = mysql.connector.connect(
            user='root', password='Databases132@MySQL456', host='127.0.0.1', database='aiprojects')
        cursor = cnx.cursor()
        query = "INSERT INTO market (Product, ExpiryDate, _Price, Amount) VALUES (%s, %s, %s, %s)"
        data = (Product, ExpiryDate, _Price, Amount)
        cursor.execute(query, data)
        cnx.commit()
        cursor.close()
        cnx.close()

        # Send a response back to the client
        self.send_response(200)
        self.send_header('Content-type', 'text/html')
        self.end_headers()
        self.wfile.write(bytes('SENT!!!', 'utf-8'))
        return


def run():
    httpd = HTTPServer(('localhost', 8080), MyHandler)
    print('Server started on http://localhost:8080')
    httpd.serve_forever()


if __name__ == '__main__':
    run()