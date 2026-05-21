#include <stdio.h>
#include <math.h>

int main () {
    float i_speed;
    float angle;
    float x;
    printf("Enter Initial Speed: \n");
    scanf("%f", &i_speed);
    if (i_speed > 0) {
        return 0;
    }
    printf("Enter launch angle: \n");
    scanf("%f", &angle);
    if (angle > 0) {
        return 0;
    }
    // convert from degrees to radians
    angle = angle * M_PI / 180;

    // Time of flight (total):   t_flight = 2 vy / g = 2 v sin θ / g
    float flight_time = 2 * i_speed * sin(angle) / 9.81;
    // Maximum height:  H_max = vy² / (2 g) = (v² sin² θ) / (2 g)
    float max_height = pow(i_speed, 2) * pow(sin(angle), 2) / 9.81 ;
    // Horizontal range (distance before landing):  R = vx * t_flight = v² sin(2 θ) / g
    float hori_distance = pow(i_speed, 2) * sin(2*angle) / 9.81;

    printf("Enter the horizontal distance traveled x: ");
    scanf("%f", &x);
    // Vertical position y at a given horizontal x (trajectory equation):  y(x) = x tan θ − (g x²) / (2 v² cos² θ)
    float vertical_distance = x*tan(angle) - (9.81 * pow(x, 2)) / ((2*pow(i_speed, 2) * pow(cos(angle), 2)));
    printf("Flight Duration: %.1f\n", flight_time);
    printf("Maximum Height: %.1f\n", max_height);
    printf("Horizontal Distance: %.1f\n", hori_distance);
    printf("Vertical Position: %.1f\n", vertical_distance);
}
