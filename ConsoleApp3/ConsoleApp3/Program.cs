#include <iostream>
#include <string>

// Base Class: Rectangle
class Rectangle
{
    protected:
    double width;
    double length;

    public:
    // Default Constructor
    Rectangle() : width(1.0), length(1.0) { }

    // Parameterized Constructor
    Rectangle(double w, double l) : width(w), length(l) { }

    // Method to get the area of the rectangle
    double GetArea() const {
        return width* length;
}
};

// Derived Class: Cuboid (inherits from Rectangle)
class Cuboid : public Rectangle
{
private:
    double height;

public:
    // Default Constructor
    Cuboid() : Rectangle(), height(1.0) { }

// Parameterized Constructor
Cuboid(double w, double l, double h) : Rectangle(w, l), height(h) { }

// Method to calculate the volume of the cuboid
double GetVolume() const {
        return width * length * height;
    }

    // Method to calculate the surface area of the cuboid
    double GetSurfaceArea() const {
        return 2 * (width * length + length * height + width * height);
    }

    // Getter for height
    double GetHeight() const {
        return height;
    }
};

// Second-Level Derived Class: ColoredCuboid (inherits from Cuboid)
class ColoredCuboid : public Cuboid
{
private:
    std::string color;

public:
    // Default Constructor
    ColoredCuboid() : Cuboid(), color("white") { }

// Parameterized Constructor
ColoredCuboid(double w, double l, double h, const std::string& c) : Cuboid(w, l, h), color(c) { }

// Method to display details of the ColoredCuboid
void DisplayDetails() const {
        std::cout << "Width: " << width << std::endl;
std::cout << "Length: " << length << std::endl;
std::cout << "Height: " << GetHeight() << std::endl;
std::cout << "Color: " << color << std::endl;
std::cout << "Surface Area: " << GetSurfaceArea() << std::endl;
std::cout << "Volume: " << GetVolume() << std::endl;
    }
};

int main()
{
    // Instance 1: Using the default constructor
    ColoredCuboid cuboid1;
    std::cout << "Details of the first ColoredCuboid (Default Constructor):" << std::endl;
    cuboid1.DisplayDetails();

    std::cout << "\n";

    // Instance 2: Using the parameterized constructor
    ColoredCuboid cuboid2(3.5, 4.5, 5.5, "blue");
    std::cout << "Details of the second ColoredCuboid (Parameterized Constructor):" << std::endl;
    cuboid2.DisplayDetails();

    return 0;
}
